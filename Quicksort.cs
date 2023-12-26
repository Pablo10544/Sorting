// See https://aka.ms/new-console-template for more information
int []arr ={4,2,3,1,7,9,11,1,1,2,1,4,5,6,7};
PrintArray(arr);
Quicksort(arr,0,arr.Length-1);
PrintArray(arr);

 void PrintArray(int[] array){
    foreach(var a in array){
Console.WriteLine(a);

}
Console.WriteLine("Lista impressa");
}

void Quicksort(int[] array,int start,int end)
{
if(start>=end){

    return;
}
int index =partition(arr,start,end);
Quicksort(arr,start,index-1);
Quicksort(arr,index+1,end);

}
int partition(int[]array,int start, int end){
int pivot = array[end];
int pivotIndex=start;
for(int i=start;i<end;i++){
if(array[i]<pivot){
swap(ref array[i],ref array[pivotIndex]);
pivotIndex++;
}
}
swap(ref array[pivotIndex],ref array[end]);
return pivotIndex;

}
void swap(ref int a,ref int b){
int temp;
temp = a;
a=b;
b= temp;
}
