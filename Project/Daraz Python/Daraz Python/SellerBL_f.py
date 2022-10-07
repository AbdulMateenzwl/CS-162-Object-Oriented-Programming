
from asyncio.windows_events import NULL


class Seller:
    name=None
    phone_num=None
    buisness = None
    password = None
    products = []

    def __init__(self, names, ph, buiss, pass_):
        self.name=names
        self.phone_num=ph
        self.buisness=buiss
        self.password=pass_
    def add_product(self,inp):
        self.products.append(inp)
    def checkproducts(self, name):
        i = 0
        while i < len(self.products):
            if name == self.products[i].getname():
                return self.products[i]
            i += 1
        return None
    def changepassword(self, pass_, pass1, pass2):
        if pass_ == self.getpassword():
            if pass1 == pass_:
                return 2
            else:
                if pass1 == pass2:
                    self.setpassword(pass1)
                    return 3
                else:
                    return 4
        else:
            return 1
    def replaceproducts(self, pre, nw):
        i = 0
        while i < len(self.products):
            if self.products[i].getname()==pre.getname() and self.products[i].get_prices()==pre.get_prices() and self.products[i].get_quantity()==pre.get_quantity():
                self.products[i] = nw
                break
            i += 1
    def deleteproducts(self, index):
        self.products.pop(index)
    def decrement(self, a):
        i = 0
        while i < len(self.products):
            if self.products[i] is a:
                if a.get_quantity()>=1:
                    a.set_quantity(a.get_quantity() - 1)
                    return True
            i += 1
        return False
    def sort_products(self):
        self.products=sorted(self.products,key=lambda Product:Product.price)
    def get_product(self,name):
        for i in range(len(self.products)):
            if(name==self.products[i].name):
                return self.products[i]
        return NULL
    def delete_product(self,inp):
        if(inp==NULL):
            return False
        else:
            self.products.remove(inp)
            return True