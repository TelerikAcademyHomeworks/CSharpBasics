taskName = "Trapezoids Area";

function Main(bufferElement) {

    var a = ReadLine("Please enter side a: ");
    var b = ReadLine("Please enter side b: ");
    var h = ReadLine("Please enter side h: ");

    SetSolveButton(function () {
        var area = FindArea(a.value, b.value, h.value)

        WriteLine("The area is: " + area);
    });
}

function FindArea(a, b, h) {

    var a = +a;
    var b = +b;
    var h = +h;

    var area = ((a + b) / 2 )* h;

    return area;
}
