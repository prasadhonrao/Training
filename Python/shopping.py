def get_order():
    print("[command] [item] (command is a to ad, d to delete, q to quit)")
    line = input()

    command = line[:1]
    item = line[2:]

    return command, item #returning a tuple!

def add_to_cart(item,cart):
    if not item in cart:
        cart[item] = 0
    cart[item] += 1    

def delete_from_cart(item,cart):
    if item in cart:
        cart[item] -= 1
        if cart[item] == 0:
            cart.pop(item, None)

def remove_items_wit_zero_qualitity(cart):
    for key in cart:
        if cart[key] == 0:
            cart.pop(key, None)
        
    
def process_order(order, cart):
    command, item = order #unpack the tuple

    if command == "a":
        add_to_cart(item, cart)
    elif command == "d" and item in cart:
        delete_from_cart(item, cart)
    elif command == "q":
        #remove_items_wit_zero_qualitity(cart)
        return False

    return True
    
def go_shopping():
    cart = dict()

    while True:
        order = get_order()
        if not process_order(order, cart):
            break

    print(cart)
    print("Finished")

go_shopping()
