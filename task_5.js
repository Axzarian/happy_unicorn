a=[1,8,3,8,2,6,8,8]
i=0
count_max=0
max=a[0]
while (i<a.length){
    if (a[i]>max){
        max=a[i]
        count_max=1
    }else {
        if (a[i]==max){
            count_max=count_max+1
        }
    }
i=i+1
}
console.log(count_max)