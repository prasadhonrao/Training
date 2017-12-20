import glob
import os
os.chdir('C:/Users/130043/20171206_CognizantNLP_CSE9098c_Day03/activity_data/')
train_files = glob.glob('train_*.txt')

train_data = []
train_categories = []

for train_file in train_files:
    with open(train_file, 'r') as f:
        _data_ = f.readlines()
        train_data.extend(_data_)
        train_categories.extend([train_file.split('_')[-1].split('.')[0]]*len(_data_))
        
test_files = glob.glob('test_*.txt')
test_data = []
test_categories = []
for test_file in test_files:
    with open(test_file, 'r') as f:
        _data_ = f.readlines()
        test_data.extend(_data_)
        test_categories.extend([test_file.split('_')[-1].split('.')[0]]*len(_data_))
        
print(len(train_data), len(test_data))
os.chdir('..')


from sklearn.cluster import KMeans
from sklearn.feature_extraction.text import TfidfVectorizer

tfidf = TfidfVectorizer()
tfidf.fit(train_data)
train_tfidf = tfidf.transform(train_data)

km = KMeans(n_clusters=3) #Specify how many clusters must be built
clusters = km.fit(train_tfidf) #This runs K-Means algo and decides where the cluster centroids are
print('Train document clusters {}'.format(clusters.predict(train_tfidf)))
#here 0 stands for one cluster and 1 stands for another

## Test data
test_tfidf = tfidf.transform(test_data)
print('Test document clusters: {}'.format(clusters.predict(test_tfidf)))