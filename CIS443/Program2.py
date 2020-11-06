# -*- coding: utf-8 -*-
"""
Program2
CIS-443-01-4208
10-11-2020
D8801
This program demonstrates the use of Statistics, built in functions, 
numpy functions, and the use of bar charts. 
"""
import matplotlib.pyplot as plt

import numpy as np

import seaborn as sns

import statistics as stats

# responses to quality of the food in a list
responses = [1,2,5,4,3,5,2,1,3,3,1,4,3,3,3,2,3,3,2,5]
# use and display built in functions
print ("Max value ",np.max(responses))
print ("Min value ",np.min(responses))
print ("Range value ",range(1, 5))
print ("Mean value ",stats.mean(responses))
print ("Median value ",stats.median(responses))
print ("Mode value ",stats.mode(responses))
print ("Variance value ",stats.variance(responses))
print ("Standard Diviation value ",np.std(responses))

values, total = np.unique(responses, return_counts=True)

# Create bar chart
title = 'Rating of Student Cafeteria 1 being "awful" and 5 being "excellent"'

sns.set_style('darkgrid')

axes = sns.barplot(x=values, y=total, palette='pastel')

axes.set_title(title)

axes.set(xlabel='Student Choices', ylabel='Total count')  

axes.set_ylim(top=max(total) * 1.10)

for bar, percentageOfTotal in zip(axes.patches, total):
    text_x = bar.get_x() + bar.get_width() / 1.8  
    text_y = bar.get_height() 
    text = f'{percentageOfTotal:,}\n{percentageOfTotal / len(responses):.2%}'
    axes.text(text_x, text_y, text, 
              fontsize=12, ha="center", va='top')