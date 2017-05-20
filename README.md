# PendleSkan
A tool which uses Google Maps API to scan the surroundings of a particular location (possible your home or potential employer) in regards to the time you need to travel to your point of interest

Preparation:
- Make sure you have access to the Google Maps API. You might need to sign up.
- In your Google developer console, setup a new project and generate an API key for this application.
- Make sure your current IP is allowed to use your newly created API key

Usage:
- During the first start, enter your API Key in the dialog which appears. If no dialog appears you can reset all setting by deleting the config.xml file
- There are two ways of setting the start position:
	1) Either look up the coordinates of the location you want to scan, enter it in the text boxes and hit "goto"
	2) Pan and drag the map to the desired location and hit "set"
- now you setup the scanning area around this starting location by adaptin the values in the "Grid online" group
- once you are done, hit "GO!" to start the scanning process. Depending on the distances you are scanning and the selected pitch, this might take a while. However, you should see progress as it is being made
- Use the Filter settings to ignore values that are not interesting to you. 
	

