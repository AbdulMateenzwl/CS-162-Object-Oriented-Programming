class UserBL:
    name=""
    password=""
    products=[]
    def __init__(self,name,password):
        self.name=name
        self.password=password
    def add_list(self,product):
        self.products.append(product)
    def get_total(self):
        total=0
        for i in range(len(self.products)):
            total+=self.products[i].price
        return total
    def clear_products(self):
        self.products.clear()