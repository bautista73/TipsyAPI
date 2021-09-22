# TipsyAPI --- API for bars and restaurants

- What it is:  
    - TipsyAPI is a simple web application created for restaurants and bars to take drink orders without having to interact with the customer.  
    - This efficinet process saves time and the headache of yelling over others at the bar to explain to the bar tender what you want to drink.
- What it does
    - TipsyAPI allows users to browse drinks, create an order with their drink, and create a payment to finish their order.
    - Currently, only one drink may be added to an order at a time.
- Endpoints

  Drinks
  - Get all Drinks:  GET https://localhost:44340/api/Drinks
  - Get Drink by DrinkId:  GET https://localhost:44340/api/Drinks/{id}
  - Create Drink:  POST https://localhost:44340/api/Drinks
  - Update a Drink:  PUT https://localhost:44340/api/Drinks
  - Delete a Drink by DrinkId:  DELETE https://localhost:44340/api/Drinks/{id}

  Order
  - Get all Orders:  GET https://localhost:44340/api/Order
  - Get Order by OrderId:  GET https://localhost:44340/api/Order/{id}
  - Create Order:  POST https://localhost:44340/api/Order
  - Update a Order:  PUT https://localhost:44340/api/Order
  - Delete a Order by OrderId:  DELETE https://localhost:44340/api/Order/{id}

  Payment
  - Get all Payments:  GET https://localhost:44340/api/Payment
  - Get Payment by PaymentId:  GET https://localhost:44340/api/Payment/{id}
  - Create Payment:  POST https://localhost:44340/api/Payment
  - Update a Payment:  PUT https://localhost:44340/api/Payment
  - Delete a Payment by PaymentId:  DELETE https://localhost:44340/api/Payment/{id}

