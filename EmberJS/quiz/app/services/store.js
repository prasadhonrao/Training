import Ember from 'ember';
import LineItem from 'quiz/models/line-item';
import Order from 'quiz/models/order';
import Product from 'quiz/models/product';

const products = [
  {title: 'Sleeping Bag', price: 10, description: 'Some desc',imageUrl: ''},
  {title: 'Towel', price: 5, description: 'Some desc',imageUrl: ''},
  {title: 'Computer', price: 200, description: 'Some desc',imageUrl: ''}
];

const orders = [
  {
    id:'1',
    name:'My order',
    items: [
      {item: 'Towel', quantity: 1},
      {item: 'Sleeping Bag', quantity: 10},
      {item: 'Computer', quantity: 5}
    ]
  },
  {
    id:'2',
    name:'Your order',
    items: [
      {item: 'Towel', quantity: 100}
    ]
  }
];

export default Ember.Service.extend({

  getProducts() {
    return products;
  },

  getOrderById(id) {
    const orders = this.getOrders();
    return orders.findBy('id', id);
  },

  getOrders() {
    return orders;
  },

  newOrder() {
     return Order.create({
      items: products.map((product) => {
        return LineItem.create({
          product: product
        });
      })
    });
  }

});
