function processData(input) {
    var inStack = [];
    var outStack = [];  
    var queries = input.split('\n').slice(1).map(query => { return query.split(' ')});
    console.log(queries.toString());

    for(var i = 0; i < queries.length; i++) {
        if(queries[i][0] == 1) {
            inStack.push(queries[i][1]);
            console.log(inStack.toString());
            console.log(outStack.toString());
        } else {
            if(outStack.length == 0){
                while(inStack.length > 0) {
                    outStack.push(inStack.pop());
                }
            }
            console.log(inStack.toString());
            console.log(outStack.toString());
            if(queries[i][0] == '2') {
                outStack.pop();
            } else {
                // console.log(q[q.length - 1]);
                console.log("peek and number would be " + outStack[outStack.length - 1]);
            }
            console.log(inStack.toString());
            console.log(outStack.toString());
        }
    }
}

var input = "10\n1 42\n2\n1 14\n3\n1 28\n3\n1 60\n1 78\n2\n2";

processData(input);

