# MinimalApiVb

Minimal Api Template for VB.net

## Usage

Use it as a template for a new project or [fork it](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/fork-a-repo) and change as needed.

## Routes

There are provided two GET routes:

- "/" Root route with a lambda function to return a Hello world message

- "/hello/{username}" A greetin function that shows the use of path parameters

Feel free to customize and expand

## Rationale

As to date there's not a web template for VB in `dotnet`. This is istantly clear if we run `dotnet new list | grep web` (yes you can use  dotnet in bash and linux in general):

```shell
ASP.NET Core Empty                            web                         [C#],F#     Web/Empty                 
ASP.NET Core Web API                          webapi                      [C#],F#     Web/Web API/API/Service   
ASP.NET Core Web API (native AOT)             webapiaot                   [C#]        Web/Web API/API/Service   
ASP.NET Core Web App (Razor Pages)            webapp,razor                [C#]        Web/MVC/Razor Pages       
Web Config                                    webconfig                               Config   
```

Just C# and some F#, no VB in sight.

Thus,  the need to have a minimal webapi also in VB; As base I recreated what can be gotten from 

```shell
dotnet new web -lang C# <projectname>
```

adding the hostname variable an a second route to show the use of path parameters.



Enjoy!

## License

Just do what the f* you want, you know the license in this case... See the relevant file for explanations if you don't.


