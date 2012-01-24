Romanian users will often type query terms without diacritics. Or they'll use
s-with-sedilla or t-with-sedilla instead of s-with-comma or t-with-comma.

This code takes a string and builds a Regex that will match any possible combination
of characters with or without diacritics that might have been intended.