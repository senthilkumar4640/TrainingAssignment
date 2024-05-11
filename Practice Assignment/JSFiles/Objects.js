var car= {
    car_brand:"tesla",car_model:"model3",price:35000,
    teslaAutoPiolt : function()
    {
        "<h2>Tesla</h2>"
    }
}
document.write(car.car_brand);

//object Constructor
function Cars(car_brand, car_model, price)
{
    this.car_brand=car_brand;
    this.car_model=car_model;
    this.price=price;
    this.teslaAutoPilot=function()
    {
        document.write("<h2>The car has auto pilot</h2>");
    }
}

var c1=new Cars("tesla", "model3", 35000);
c1.teslaAutoPilot();

var str1=new String();
document.write(typeof(str1)); //checking datatype

//add
Cars.fuelType = "electric";

//delete
delete Cars.price;