taskName = "Is Prime";

function Main(bufferElement) {

    var number = ReadLine("Please enter a number: ");

    SetSolveButton(function () {
        var isPrime = IsPrime(number.value);

        WriteLine(isPrime);
    });
}

function IsPrime(number) {
    var isPrime = true;

    if( number == 0 || number == 1) {
        isPrime = false;
    }
    else {
        for (var i = 2; i <= Math.sqrt(number); i++) {
            if(number % i == 0) {
                isPrime = false;
                break;
            }
        }
    }

    return isPrime;
}