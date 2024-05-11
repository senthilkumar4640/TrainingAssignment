"use strict";
//Basic Data Types
let id = 5;
let company = "senthil";
let isFlag = true;
//any Data Type
let x = 5;
let y = "senthil";
let z;
z = 0;
z = "kumar";
z = true;
//Array
//number array
let ids = [1, 2, 3, 4, 5];
ids.push(8);
ids.pop();
//string array
let str = ["senthil", "kumar", "bhuvi"];
str.push("Hi");
str.pop();
//any array
let array = [1, 2, "senthil", 4, "kumar"];
//Tuple
let employee = [1, "senthil", true];
//Tuple Array
let employees = [
    [1, "senthil", true],
    [2, "Bhuvi", true],
    [3, "kumar", false]
];
//union
let employeeID;
employeeID = 5;
employeeID = "SF05";
//enum
var direction1;
(function (direction1) {
    direction1[direction1["up"] = 0] = "up";
    direction1[direction1["down"] = 1] = "down";
    direction1[direction1["left"] = 2] = "left";
    direction1[direction1["right"] = 3] = "right";
})(direction1 || (direction1 = {}));
console.log(direction1.right);
var direction2;
(function (direction2) {
    direction2[direction2["up"] = 5] = "up";
    direction2[direction2["down"] = 6] = "down";
    direction2[direction2["left"] = 7] = "left";
    direction2[direction2["right"] = 8] = "right";
})(direction2 || (direction2 = {}));
console.log(direction2.down);
var direction3;
(function (direction3) {
    direction3["up"] = "up";
    direction3["down"] = "down";
    direction3["left"] = "left";
    direction3["right"] = "right";
})(direction3 || (direction3 = {}));
console.log(direction3.left);
let User = {
    id: 1,
    name: "senthil"
};
//type assertion
let x3 = 5;
let company1 = x3;
let x4 = 5;
let company2 = x4;
//function
//number
function doMath(a, b) {
    return a + b;
}
console.log(doMath(1, 2));
//string
function doString(a) {
    return a;
}
console.log(doString("senthil"));
//union
function union(a) {
    console.log(a);
}
union("senthil");
function union1(a) {
    if (typeof a === "number")
        console.log("Hi Number");
    if (typeof a === "string")
        console.log("Hi String");
}
union1(2);
union1("Senthil");
let User1 = {
    id: 1,
    name: "senthil"
};
let User2 = {
    id: 1,
    name: "senthil"
};
const add = (x, y) => x + y;
const sub = (x, y) => x - y;
//classes
class Person {
    constructor(id, name) {
        this.id = id;
        this.name = name;
    }
}
const obj1 = new Person(1, "senthil");
const obj2 = new Person(2, "Bhuvi");
const obj3 = new Person(3, "Kumar");
console.log(obj1, obj2, obj3);
//Data Modifiers
class Person1 {
    constructor(id1, name) {
        this.id1 = id;
        this.name = name;
    }
    register() {
        return (`${this.name} is registered now`);
    }
}
const obj11 = new Person1(1, "senthil");
const obj12 = new Person1(2, "Bhuvi");
const obj13 = new Person1(3, "Kumar");
//console.log(obj11.id1);
console.log(obj11.register());
class Person2 {
    constructor(id, name) {
        this.id = id;
        this.name = name;
    }
    register() {
        return (`${this.name} is registered now`);
    }
}
const obj111 = new Person2(1, "senthil");
const obj122 = new Person2(2, "Bhuvi");
const obj133 = new Person2(3, "Kumar");
//console.log(obj11.id1);
console.log(obj11.register());
//Extending the Class
//childclass
class Employee extends Person2 {
    constructor(id, name, position) {
        super(id, name);
        this.position = position;
    }
}
const emp1 = new Employee(1, "senthil", "software engineer");
console.log(emp1.id);
console.log(emp1.register());
//Generics
function getArray(items) {
    return new Array().concat(items);
}
let numArray = getArray([1, 2, 3, 4, 5]);
let strArray = getArray(["senthil", "bhuvi"]);
numArray.push(10);
strArray.push("kumar");
console.log(numArray[0]);
console.log(numArray[1]);
console.log(numArray[2]);
console.log(numArray[3]);
console.log(numArray[4]);
console.log(numArray[5]);
console.log(numArray[6]);
console.log(strArray[0]);
console.log(strArray[1]);
console.log(strArray[2]);
