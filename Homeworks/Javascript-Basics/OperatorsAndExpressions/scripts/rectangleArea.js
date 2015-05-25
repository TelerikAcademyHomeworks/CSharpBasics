taskName = "Rectangle area";

function Main(bufferElement) {

    var a = ReadLine("Please enter a number: ");
    var b = ReadLine("Please enter b number: ");

    SetSolveButton(function () {
        var rectArea = CalcRectangleArea(a.value, b.value);
        WriteLine(rectArea);
    });
}

function CalcRectangleArea(a, b) {
    return a * b;
}