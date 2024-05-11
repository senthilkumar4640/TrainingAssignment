var car1="Audi";
var car2="BMW";
var car3="Benz"

//Creating an array
var cars = ["audi", "bmw", "volvo"];

document.writeln(cars);

for(var i=0; i<3; i++)
{
    document.writeln(cars[i]);
}

//new keyword
var array1 = new Array("mango","banana","apple");
for(var i=0; i<3; i++)
{
    document.writeln(array1[i]);
}

array1.push("mercedes")
array1.push(2);
array1.pop();
for(var i=0; i<array1.length; i++)
{
    document.writeln(array1[i]);
}
