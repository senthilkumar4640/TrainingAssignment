//Basic Data Types
let id: number = 5;
let company: string = "senthil";
let isFlag: boolean = true;

//any Data Type
let x: any = 5;
let y: any = "senthil";
let z: any;
z = 0;
z = "kumar";
z = true;


//Array

//number array
let ids: number[] = [1, 2, 3, 4, 5];
ids.push(8);
ids.pop();

//string array
let str: string[] = ["senthil", "kumar", "bhuvi"];
str.push("Hi");
str.pop();

//any array
let array: any[] = [1, 2, "senthil", 4, "kumar"];


//Tuple
let employee: [number, string, boolean] = [1, "senthil", true];

//Tuple Array
let employees: [number, string, boolean][] = [
    [1, "senthil", true],
    [2, "Bhuvi", true],
    [3, "kumar", false]
];

//union
let employeeID: string | number;
employeeID = 5;
employeeID = "SF05";

//enum
enum direction1 {
    up,
    down,
    left,
    right
}
console.log(direction1.right);

enum direction2 {
    up = 5,
    down,
    left,
    right
}
console.log(direction2.down);

enum direction3 {
    up = "up",
    down = "down",
    left = "left",
    right = "right"
}
console.log(direction3.left);


//object
type userType = {
    id: number,
    name: string
}

let User: userType = {
    id: 1,
    name: "senthil"
}


//type assertion
let x3: any = 5;
let company1 = x3 as number;

let x4: any = 5;
let company2 = <number>x4;


//function

//number
function doMath(a: number, b: number): number {
    return a + b;
}
console.log(doMath(1, 2));

//string
function doString(a: string): string {
    return a;
}
console.log(doString("senthil"));

//union
function union(a: string | number): void {
    console.log(a);
}
union("senthil")

function union1(a: string | number): void {
    if (typeof a === "number")
        console.log("Hi Number")
    if (typeof a === "string")
        console.log("Hi String")
}
union1(2);
union1("Senthil");


//interface
interface userType1 {
    id: number,
    name: string,
    age?: number  // ?--optional parameter
}

let User1: userType1 = {
    id: 1,
    name: "senthil"
}

interface userType2 {
    readonly id: number, //cannot reassign
    name: string,
    age?: number  // ?--optional parameter
}

let User2: userType2 = {
    id: 1,
    name: "senthil"
}
//User2.id=9;

//interface function
interface MathFunc {
    (x: number, y: number): number
}

const add: MathFunc = (x: number, y: number) => x + y;
const sub: MathFunc = (x: number, y: number) => x - y;


//classes
class Person {
    id: number;
    name: string;

    constructor(id: number, name: string) {
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
    private id1: number;
    name: string;

    constructor(id1: number, name: string) {
        this.id1 = id;
        this.name = name;
    }
    register() {
        return(`${this.name} is registered now`)
    }
}

const obj11 = new Person1(1, "senthil");
const obj12 = new Person1(2, "Bhuvi");
const obj13 = new Person1(3, "Kumar");

//console.log(obj11.id1);

console.log(obj11.register());


//implements interface in class

interface PersonType {
    id: number,
    name: string,
    register() : string
}

class Person2 implements PersonType {
    id: number;
    name: string;

    constructor(id: number, name: string) {
        this.id = id;
        this.name = name;
    }
    register() {
        return(`${this.name} is registered now`)
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
    position : string;

    constructor(id:number, name:string, position:string)
    {
        super(id, name);
        this.position = position;
    }
}

const emp1 = new Employee(1,"senthil","software engineer");
console.log(emp1.id);
console.log(emp1.register());


//Generics
function getArray<T>(items: T[]) : T[] {
    return new Array().concat(items);
}

let numArray = getArray<number>([1,2,3,4,5]);
let strArray = getArray<string>(["senthil","bhuvi"]);
numArray.push(10);
strArray.push("kumar");
console.log(numArray[0])
console.log(numArray[1])
console.log(numArray[2])
console.log(numArray[3])
console.log(numArray[4])
console.log(numArray[5])
console.log(numArray[6])
console.log(strArray[0])
console.log(strArray[1])
console.log(strArray[2])
