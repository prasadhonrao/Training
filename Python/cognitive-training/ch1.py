import nltk
from nltk.tokenize import sent_tokenize, word_tokenize
from nltk import FreqDist

# with open(r'C:/Users/130043/20171204_CognizantNLP_CSE9098c_Day01/data/cognizant_tweets.txt', 'r') as f:
#     words = f.read()

# stopwords = nltk.corpus.stopwords
# eng_stopwords = stopwords.words('english')

# words = word_tokenize(words.lower())

# words_exclude = [word for word in words if word not in eng_stopwords]

# freqs_exclude = nltk.FreqDist(words_exclude)
# print(freqs_exclude.most_common(20))

# freqs_exclude = nltk.FreqDist(words)
# print(freqs_exclude.most_common(20))

# with open(r'C:/Users/130043/20171204_CognizantNLP_CSE9098c_Day01/data/cognizant_tweets.txt', 'r') as f:
#     words = f.read()
#     words = words.replace("\n", "").split(" ")
    
# # print(words)

# words_hash = [word for word in words if word.startswith("#")]

# # print(words_hash)

# freqs_hash = nltk.FreqDist(words_hash)
# print(freqs_hash.most_common(10))


# 4. %

# with open(r'C:/Users/130043/20171204_CognizantNLP_CSE9098c_Day01/data/cognizant_tweets.txt', 'r') as f:
#     words = f.read()
#     words = words.split('\n')

# words_rt = [word for word in words if word.startswith("RT")]
# print((len(words_rt) / len(words)) * 100)

# 5.0

from sklearn.feature_extraction.text import TfidfVectorizer

with open(r'C:/Users/130043/20171204_CognizantNLP_CSE9098c_Day01/data/cognizant_tweets.txt', 'r') as f:
    words = f.read()
    words = words.split('\n')

tfidf = TfidfVectorizer() #blank tfidf calculator
tfidf.fit(words) #load the data and store the tf and idf values
train_tfidf = tfidf.transform(words) #create the tfidf matrix
print(train_tfidf.shape)

from sklearn.metrics.pairwise import cosine_similarity

list_scores = {}

for row_num, row in enumerate(train_tfidf):
    # print('Similarity between tweet #{} and #{} is: {:.3f}'.format(1, row_num+1, cosine_similarity(train_tfidf[4], row)[0][0]))
    list_scores.update({row_num : float(cosine_similarity(train_tfidf[4], row)[0][0])})

# print(list_scores.values())

print(sorted(list_scores, key=lambda x: list_scores[x], reverse=True)[1])

print(words[3])
print(words[4])

# print(sorted(list_scores))

# import numpy as np
# np_array_sort = np.sort(list_scores)

# print(np_array_sort)

# new_array = np.sort(list_scores)[::-1]
# print(new_array[1][0])
