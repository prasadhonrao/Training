(function foo() {
  let bar = "bar"; 
  console.log(bar + " " +  bam + " " + baz);  // ReferenceError for baz 
  
  var bam = "bam";
  let baz = "baz"; 
}());