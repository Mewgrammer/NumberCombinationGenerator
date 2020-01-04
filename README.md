# Number Combination Generator

This is a small .NetCore 3.1 App for generating number combinations.
 
## CLI
The Number Combination Generator offers a CLI.

Parameter  | Description
------------- | ------------- 
--help      | Display Help
-s, --size  | The Size of the Combination (Default: 4)
--min  | Minimum Value of numbers in the combination (Default: 0)
--max  | Maximum Value for numbers in the combination (Default: 20)
-c, --count  | # of combinations to generate (Default: 10)
--dc  | allow duplicate combinations (Default: false)
--dn  | allow duplicate numbers inside combinations (Default: false)

### Usage
Run the NumberCombinationGeneratorCli.exe with optional parameters.
The Console will display the generated combinations. 


## Web App
The Number Combination Generator offers a Blazor Web App.

![Screenshot](https://github.com/Mewgrammer/NumberCombinationGenerator/blob/master/doc/WebApp.png)

### Usage
Run the NumberCombinationGenerator.exe, then start your browser and go to http://localhost:5000 or https://localhost:5001.
Use the Form to edit parameters and press the "Generate"-Button to receive a list of generated values inside a textarea.



## License

BlazingComponents is licensed under [MIT license](http://www.opensource.org/licenses/mit-license.php)


## Credits
CLI uses the awesome [Command Line Parser](https://github.com/commandlineparser/commandline)