// sqaure function accepting an int and returning an int
let sqaure x = x * x;
let sqaured = List.map sqaure [1;2;3]
for i in sqaured do
   printfn "%d" i


// sqaure function accepting an float and returning an float
let square2 (x:float) : float = x * x
let sqaured2 = List.map square2 [1.2;2.5;3.9]
for j in sqaured2 do
   printfn "%f" j