namespace _03.Store_Boxes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new();

            while(command != "end")
            {
                string[] data = command.Split();
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item currentItem = new Item
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box currentBox = new Box
                {
                    SerialNumber = serialNumber,
                    Item = currentItem,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemQuantity * itemPrice,
                };
                boxes.Add(currentBox);


                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach(Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }

        }
    }
}