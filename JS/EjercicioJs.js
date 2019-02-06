function Employee(first, last, salary) {
    this.firstName = first;
    this.lastName = last;
    this.salary = salary;

  }
  Employee.prototype.SalaryRaise = function()
  {
     this.salary+= 1000;
  }
  Employee.prototype.ShowDetails = function()
  {
      return "The employee: "+ this.lastName + ", "+ this.firstName+ " has a salary of: $"+this.salary;
  }
  function TestPerson(){
      var employee = new Employee("Roberto","Perez", 3000);
      console.log(employee.ShowDetails());
      employee.SalaryRaise();
      console.log(employee.ShowDetails());
  }
  //FIN EJERCICIO 1

  function MultiplyBy(x)
  {
      return function(y){
        return function(z){
            return (x*y)*z;
        }
      }
  }

  function TestMultiplyBy()
  {
      console.log(MultiplyBy(2)(3)(4));
      console.log(MultiplyBy(4)(3)(4));
  }
// FIN EJERCICIO 2

function Longest_Country_Name(params){
return params.reduce(function(a, b) { 
  return a.length > b.length ? a : b
}, '');
}

function Test_Longest_Country_Name(){
    console.log(Longest_Country_Name(["Australia", "Germany", "United States of America"]));
}

//FIN EJERCICIO 3

function removecolor()
{
    $("#colorSelect option:selected").remove();
}

//FIN EJERCICIO 4

function insert_Row(){
    var rowCount = $('#sampleTable tr').length;
    rowCount++;
    $('#sampleTable tr:last').after('<tr><td>Row'+rowCount+ ' cell1</td><td>Row'+rowCount+ ' cell2</td></tr>');
}

//FIN EJERCICIO 5