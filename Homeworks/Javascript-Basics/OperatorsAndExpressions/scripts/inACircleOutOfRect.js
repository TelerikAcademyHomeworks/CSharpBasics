taskName = "Point in a circle out of rectangle";

function Main(bufferElement) {

    var xCoordinate = ReadLine("Please enter x coordinate of the point: ");
    var yCoordinate = ReadLine("Please enter y coordinate of the point: ");
    var xCoordCircle = 1;
    var yCoordCircle = 1;
    var radius = 3;
    var xCoordRect = -1;
    var yCoordRect = 1;
    var rectWidth = 6;
    var rectHeight = 2;

    SetSolveButton(function () {
        var isInCircle = IsInCircle(xCoordinate.value, yCoordinate.value, xCoordCircle, yCoordCircle, radius, xCoordRect, yCoordRect, rectWidth, rectHeight);

        WriteLine(isInCircle);
    });
}

function IsInCircle(xCoord, yCoord, xCoordCircle, yCoordCircle, radius, xCoordRect, yCoordRect, rectWidth, rectHeight) {

    if(Math.pow(xCoord - xCoordCircle, 2) + Math.pow(yCoord - yCoordCircle, 2) <= Math.pow(radius, 2)
        && (xCoord < xCoordRect || xCoord > xCoordRect + rectWidth)
        && (yCoord > yCoordRect || yCoord < yCoordRect - rectHeight)) {
        return true;
    }
    else {
        return false;
    }
}

