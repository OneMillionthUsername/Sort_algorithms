Random Random = new();

List<int> Numbers = new();
for (int i = 0; i < 100; i++) {
	Numbers.Add(Random.Next(100));
}
Console.WriteLine("Unsortiert: ");
foreach (var item in Numbers) {
	Console.Write(item + ", ");
}
//QuickSort(Numbers);
BubbleSort(Numbers);
Console.WriteLine();
Console.WriteLine("Sortiert: ");
foreach (var item in Numbers) {
	Console.Write(item + ", ");
}

void BubbleSort(List<int> intList) {
	for (int i = 0; i < intList.Count-1; i++) {
		for (int j = 0; j < intList.Count-1 - i; j++) {
			if (intList[j] > intList[j + 1]) {
				(intList[j + 1], intList[j]) = (intList[j], intList[j + 1]);
			}
		}
	}
}

void QuickSort(List<int> intList) {
	int pivot = intList[0];
	List<int> listeLinks = new();
	List<int> listeRechts = new();

	for (int i = 1; i < intList.Count; i++) {
		if (intList[i] < pivot) {
			listeLinks.Add(intList[i]);
		}
		else {
			listeRechts.Add(intList[i]);
		}
	}
	if (listeLinks.Count > 1) {
		QuickSort(listeLinks);
	}
	if (listeRechts.Count > 1) {
		QuickSort(listeRechts);
	}

	intList.Clear();

	for (int i = 0; i < listeLinks.Count; i++) {
		intList.Add(listeLinks[i]); 
	}

	intList.Add(pivot);

	for (int i = 0; i < listeRechts.Count; i++) {
		intList.Add(listeRechts[i]); 
	}
}