from pprint import pprint as pp

country_to_captial = { 
                        'India': 'Delhi',
                        'UK': 'London',
                        'USA': 'Washington'
                     }

# Display capital name tagged with country name using comprehension 
country_to_captial = { capital: country for country, capital in country_to_captial.items()}
pp(country_to_captial)