using System.Collections;

ArrayList list = new ArrayList();
list.Add("Şükrü");
list.Add(24);
list.Add('F');
list.Add(true);

Console.WriteLine(list[0]);

foreach (var i in list) {
    Console.WriteLine(i);
}

int[] numbers = {23,454,3,56,5656};
list.Add(numbers);


list.Clear();