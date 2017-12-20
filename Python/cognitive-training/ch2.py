import glob, os
import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from nltk.stem import WordNetLemmatizer
import re

os.chdir('C:/Users/130043/20171205_CognizantNLP_CSE9098c_Day02/sample_data/') #change directory to where the folders are
folders = glob.glob('*') #load all the folder names into a list

# print(folders)

all_texts = []
all_categories = []

for folder in folders:
    # print('importing text files from "{}" folder...'.format(folder), end=' ')
    
    files_in_folder = glob.glob(folder+'/*.txt')
    
    for _file_ in files_in_folder:
        with open(_file_, 'r', encoding='latin-1') as f:
            text_in_file = f.read()
            all_texts.append(text_in_file)
            all_categories.append(folder)
            
    # print('found {} files'.format(len(files_in_folder)))
        
os.chdir('../') #revert back to original working directoy

# print(len(all_texts))
# print(all_categories)

stopwords = nltk.corpus.stopwords
eng_stopwords = stopwords.words('english')
wordnet_lemmatizer = WordNetLemmatizer()

def basic_preprocessing(text):
    text = text.lower() #lowering
    text = re.sub(r'\[.*?\]', '', text) #removing all instances of citation brackets found in wiki articles
    text = word_tokenize(text)
    text = [word for word in text if word not in eng_stopwords] #removing stop words
    text = [wordnet_lemmatizer.lemmatize(word) for word in text]

    return(text)

processed_texts = [basic_preprocessing(text) for text in all_texts]
# print(len(processed_texts))
all_words = set([word for document in processed_texts for word in document]) # this is a nested for loop!!
# print(len(all_words))

def get_featureset(document):
    return({word: (word in document) for word in all_words})

processed_texts = [get_featureset(document) for document in processed_texts]
# print(processed_texts[0])
# print(len(processed_texts[0]))

test_texts = all_texts[0:3] + all_texts[10:13]
test_data = processed_texts[0:3] + processed_texts[10:13]
test_target = all_categories[0:3] + all_categories[10:13]

train_texts = all_texts[3:10] + all_texts[13:20]
train_data = processed_texts[3:10] + processed_texts[13:20]
train_target = all_categories[3:10] + all_categories[13:20]

train_data_return = list(zip(train_data, train_target))

# print(train_data_return[0])
# print(type(train_data_return[0]))

classifier = nltk.NaiveBayesClassifier.train(train_data_return)
classifier.show_most_informative_features()

test_predictions = classifier.classify_many(test_data)
print(test_predictions)

from sklearn.metrics import accuracy_score

#backslash means the function continues in next line\
print('Accuracy on test data: {}%'.format(\
                                          accuracy_score(test_target, test_predictions)\
                                          *100))
