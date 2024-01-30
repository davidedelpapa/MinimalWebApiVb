Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Http

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()
        app.MapGet("/", Function() "Hello World!")

        app.Run("http://localhost:5000")
    End Sub
End Module
