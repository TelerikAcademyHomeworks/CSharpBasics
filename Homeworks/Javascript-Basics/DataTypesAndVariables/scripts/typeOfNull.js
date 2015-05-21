taskName = "";

function Main(bufferElement) {

    SetSolveButton(function () {

        var nullable = null;
        WriteLine("This is nullable typeof: " + typeof(nullable));

        var undefined;
        WriteLine("This is not a number typeof: " + typeof(undefined));
    });
}
