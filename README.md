# MinimalApiVb

Minimal Api Template for VB.net

## Usage

Use it as a template for a new project or [fork it](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/fork-a-repo) and change it as needed.

## Routes

There are provided two GET routes:

- "/" Root route with a lambda function to return a Hello world message

- "/hello/{username}" A greeting function that shows the use of path parameters

Feel free to customize and expand

## VB.NET Version

As usual, you can change the VB.NET Version as needed, by modifying the following line in the *MinimalApiVb.vbproj* file:

```xml
<TargetFramework>net8.0</TargetFramework>
```

## Rationale

As of this date, there's not a web template for VB in `dotnet`. This is instantly clear if we run `dotnet new list | grep web` (yes you can use  dotnet in bash and Linux in general):

```shell
ASP.NET Core Empty                            web                         [C#],F#     Web/Empty                 
ASP.NET Core Web API                          webapi                      [C#],F#     Web/Web API/API/Service   
ASP.NET Core Web API (native AOT)             webapiaot                   [C#]        Web/Web API/API/Service   
ASP.NET Core Web App (Razor Pages)            webapp,razor                [C#]        Web/MVC/Razor Pages       
Web Config                                    webconfig                               Config   
```

Just C# and some F#, no VB in sight.

Thus,  the need to have a minimal WebAPI also in VB; As a base, I recreated what can be gotten from:

```shell
dotnet new web -lang C# <projectname>
```

adding the hostname variable and a second route to show the use of path parameters.

Enjoy!

## License

Just do what the f* you want, you know the license in this case... See the relevant file for explanations if you don't.
