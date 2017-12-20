# Day 2 Activity Challenge

import glob, os
import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from nltk.stem import WordNetLemmatizer
import re

os.chdir('C:/Users/130043/20171205_CognizantNLP_CSE9098c_Day02/activity_data/')
train_files = glob.glob('train_*.txt')

train_data = []
train_categories = []

for train_file in train_files:
    with open(train_file, 'r') as f:
        _data_ = f.readlines()
        train_data.extend(_data_)
        train_categories.extend([train_file.split('_')[-1].split('.')[0]]*len(_data_))
        
# print(len(train_data))
# print(train_categories)
        
test_files = glob.glob('test_*.txt')

test_data = []
test_categories = []

for test_file in test_files:
    with open(test_file, 'r') as f:
        _data_ = f.readlines()
        test_data.extend(_data_)
        test_categories.extend([test_file.split('_')[-1].split('.')[0]]*len(_data_))
        
# print(len(train_data), len(test_data))
os.chdir('..')

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

train_processed_texts = [basic_preprocessing(text) for text in train_data]
# print(len(train_processed_texts))
train_words = set([word for document in train_processed_texts for word in document]) # this is a nested for loop!!
# print(len(train_words))

test_processed_texts = [basic_preprocessing(text) for text in test_data]
# print(len(test_processed_texts))
test_words = set([word for document in test_processed_texts for word in document]) # this is a nested for loop!!
# print(len(test_words))

def get_featureset(document):
    return({word: (word in document) for word in train_words})

train_processed_texts = [get_featureset(document) for document in train_processed_texts]
# print(train_processed_texts[0])
# print(len(train_processed_texts[0]))

test_processed_texts = [get_featureset(document) for document in test_processed_texts]
# print(test_processed_texts[0])
# print(len(test_processed_texts[0]))

# test_texts = all_texts[0:3] + all_texts[10:13]
# test_data = processed_texts[0:3] + processed_texts[10:13]
# test_target = all_categories[0:3] + all_categories[10:13]

# train_texts = all_texts[3:10] + all_texts[13:20]
# train_data = processed_texts[3:10] + processed_texts[13:20]
# train_target = all_categories[3:10] + all_categories[13:20]

train_data_return = list(zip(train_processed_texts, train_categories))

# print(train_data_return[0])
# print(type(train_data_return[0]))

classifier = nltk.NaiveBayesClassifier.train(train_data_return)
classifier.show_most_informative_features()

test_predictions = classifier.classify_many(test_processed_texts)
from sklearn.metrics import accuracy_score

print('Accuracy on test data: {}%'.format(\
                                          accuracy_score(test_categories, test_predictions)\
                                          *100))
