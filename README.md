# EmailFeaturesExtraction
implemented an open source and flexible tool to provide the ability to extract the features that are mentioned in previous section using any email corpus have emails with EML extension. Then the tool will split the emails’ parts (From, To, CC, BCC, Subject, Text Body, and HTML Body) in an output file and extract the selected features in another one as a CSV file., if errors occurred during the extraction process an error file will be generated as well.
EML file extension is one of the most common extensions for the exported emails from many email applications such as Outlook, Thunderbird and Gmail. Email files in the corpora can be converted easily to the EML extension by rename it to any names with this extension.  

The tool uses the following external packages:
1.HTML Agility Pack :External package to parse HTML. Available at:   https://htmlagilitypack.codeplex.com/
2.IKVM.NET :External package to enable Java and .NET interoperability. Available at:    https://www.ikvm.net/
3.Stanford.NLP.CoreNLP :External package to provides a set of natural language analysis tools. Available at:    https://www.nuget.org/packages/Stanford.NLP.CoreNLP/
