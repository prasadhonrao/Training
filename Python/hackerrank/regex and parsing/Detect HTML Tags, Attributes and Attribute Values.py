from html.parser import HTMLParser

class CustomHTMLParser(HTMLParser):
    # runs it for every start tag in the document
    def handle_starttag(self, tag, attrs):
        print(tag)
        [print('-> {} > {}'.format(*attr)) for attr in attrs]
        
input_html = '\n'.join([input() for _ in range(int(input()))])
parser = CustomHTMLParser()
parser.feed(input_html)
parser.close()