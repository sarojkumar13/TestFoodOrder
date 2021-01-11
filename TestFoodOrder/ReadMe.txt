1. An Api is created to find the Total price based on drink
http://localhost:5000/api/Order/ItemTotal
2. Swagger can be used to test the api
http://localhost:5000/swagger/index.html
3. Model Example

[{
    "Id": 1,
    "Name": "Lemo",
    "Price": 10.00,
    "ItemTypeId": 1
},
{
    "Id": 2,
    "Name": "Burger",
    "Price": 10.00,
    "ItemTypeId": 2
}
]

4. ItemTypeId is  Food/Drink type

enum FoodType
    {
        Food = 1,
        Drink = 2
    };
