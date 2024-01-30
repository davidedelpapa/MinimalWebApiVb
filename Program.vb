Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Http

Module Program
    Sub Main(args As String())
        Dim host = "http://localhost:5000"

        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()

        app.MapGet("/hello/{username}", Function(username as String) "Hello "& username &"!")
        app.MapGet("/", Function() "Hello World!")

        app.Run(host)
    End Sub
End Module
