// Function Assignment by Jordan. A
#nullable disable
List<int> nums = new List<int>{2, 4, 6, 8, 10};


// contains Function
bool contains(List<int> aList, int item) {
    for (int n = 0; n < aList.Count; n++) {
        if (aList[n] == item) {
            return true;
        } 
    }
    return false;
}

// indexOf Function
int indexOf(List<int> aList, int item) {
    for (int n = 0; n < aList.Count; n++) {
        if (aList[n] == item) {
            return n;
        } 
    }
    return -1;
}

// reverse Function
List<int> reverse(List<int> aList) {
    List<int> reverse = new List<int>();
    for (int n = aList.Count - 1; n >= 0; n--) {
        reverse.Add(aList[n]);
    }
    return reverse;
}

// swap Function
void swap(List<int> aList, int index1, int index2) {
    int indexValue1 = aList[index1];
    aList[index1] = aList[index2];
    aList[index2] = indexValue1;
}

// indexOfMin Function
int indexOfMin(List<int> aList) {
    int minIndex = aList.Count;
    int min = aList[0];
    for (int n = 0; n < aList.Count; n++) {
        if (aList[n] < min) {
            minIndex = n;
            min = aList[n];
        }
    }
    return minIndex;
}


// Testing Functions

// contains
if (contains(nums, 8)) {
  Console.WriteLine("8 is IN the List");
} else {
  Console.WriteLine("8 is NOT in the List");
}

// indexOf
int index = indexOf(nums, 2);
if (index != -1) {
  Console.WriteLine($"2 IN list at index: {index}");
} else {
  Console.WriteLine("2 NOT in list");
}

// reverse
List<int> reversedNums = reverse(nums);
for (int n = 0; n < reversedNums.Count; n++) {
    Console.Write($"{reversedNums[n]} ");
}

// swap
Console.WriteLine("swap");
swap(nums, 0, 4);
for (int n = 0; n < nums.Count; n++) {
    Console.Write($"{nums[n]} ");
}

// indexOfMin

int minIndex = indexOfMin(nums);
Console.WriteLine($"The min index is{minIndex}");