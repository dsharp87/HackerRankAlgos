
function triplets(a, b, c) {
    //could sort both a and c
    //iterate through b
    //count how many values are <= in both a and c
    //multiply those two counts
    //returns sum of all count multiples

    a.sort((x,y) => x-y);
    b.sort((x,y) => x-y);
    c.sort((x,y) => x-y);
    var total = 0;
    var sumA = 0;
    var sumC = 0;
    var idxa = 0;
    var idxc = 0;
    for(var i = 0; i < b.length; i++)
    { 
        var val = b[i];
        if(i != 0 && b[i-1] == val)
            continue;
        while(a[idxa] <= val && idxa < a.length)
        {   
            var valA = a[idxa];
            sumA++;
            while(a[idxa] == valA)
                idxa++;
        }
        while(c[idxc] <= val && idxc < c.length)
        {
            var valC = c[idxc]
            sumC++;
            while(c[idxc] == valC)
                idxc++;
        }
        if(sumA != 0 && sumC !=0)
            total+= sumA*sumC;
    }
    return total;
}

var a = [1,3,5,7]
var b = [5,7,9]
var c = [7,9,11,13]

console.log(triplets(a,b,c))