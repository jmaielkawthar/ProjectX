interface Person {
    name: string;
    age: number;

}
function sortbyName(a: Person[]) {
    var result = a.slice(0);
    result.sort((x, y) => {
        return x.name.localeCompare(y.name);
    })
    return result;
}
sortbyName([]);
class greeter {
    name: string;
    SayHello() {
        Console.log("hello" + name);
    }
}
