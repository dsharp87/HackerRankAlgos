function pairs(k, arr) {
    //get a dictionary
    //contains encountered values
    //when each value is encountered,
    //check if current val + k exists And if value is bigger than K, if current -k exists

    var total = 0;
    var vals = new Object();
    for(var i=0; i< arr.length; i++)
    {
        if(arr[i]+k in vals)
            total++;
        if(arr[i] >= k) 
        {
            if(arr[i] -k in vals)
                total++;
        }
        vals[arr[i]] = 1;
    }
    return total;
}