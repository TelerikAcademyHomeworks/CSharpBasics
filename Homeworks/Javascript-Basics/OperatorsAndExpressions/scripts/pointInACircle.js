taskName = "Point in a circle";

function Main(bufferElement) {

    var xCoordinate = ReadLine("Please enter x coordinate of the point: ");
    var yCoordinate = ReadLine("Please enter y coordinate of the point: ");
    var xCoordCircle = 0;
    var yCoordCircle = 0;
    var radius = 5;

    SetSolveButton(function () {
        var isInCircle = IsInCircle(xCoordinate.value, yCoordinate.value, xCoordCircle, yCoordCircle, radius);

        WriteLine(isInCircle);
    });
}

function IsInCircle(xCoord, yCoord, xCoordCircle, yCoordCircle, radius) {

    if(Math.pow(xCoord - xCoordCircle, 2) + Math.pow(yCoord - yCoordCircle, 2) < Math.pow(radius, 2)) {
        return true;
    }
    else {
        return false;
    }
}

