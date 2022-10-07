from asyncio.windows_events import NULL
from SellerBL_f import Seller
class SellerDL:
    path = "seller.txt"
    seller = []
    @staticmethod
    def get_seller():
        return SellerDL.seller
    @staticmethod
    def add_list(input):
        SellerDL.seller.append(input)
    @staticmethod
    def get_list():
        return SellerDL.seller
    @staticmethod
    def get_seller_data(seller_name, pass_):
        i = 0
        while i < len(SellerDL.seller):
            if seller_name == SellerDL.seller[i].name and pass_ == SellerDL.seller[i].password:
                return SellerDL.seller[i]
            i += 1
        return NULL
    @staticmethod
    def get_seller(seller_name):
        i = 0
        while i < len(SellerDL.seller):
            if seller_name == SellerDL.seller[i].name:
                return SellerDL.seller[i]
            i += 1
        return NULL
    @staticmethod
    def delete_seller(Seller):
        if(Seller==NULL):
            return False
        else:
            SellerDL.seller.remove(Seller)
            return True
    @staticmethod
    def get_product(product):
        for i in range(len(SellerDL.seller)):
            for m in range(len(SellerDL.seller[i].products)):
                if product==SellerDL.seller[i].products[m].name :
                    return SellerDL.seller[i].products[m]
        return None
    # @staticmethod
    # def replace(pre, nw):
    #     i = 0
    #     while i < len(Daraz_V_Convert.DL.SellerDL._seller):
    #         if pre.get_name() == Daraz_V_Convert.DL.SellerDL.get_seller()[i].get_name() and pre.get_buisness() == Daraz_V_Convert.DL.SellerDL.get_seller()[i].get_buisness() and pre.get_phone_num() == Daraz_V_Convert.DL.SellerDL.get_seller()[i].get_phone_num() and pre.get_password() == Daraz_V_Convert.DL.SellerDL.get_seller()[i].get_password():
    #             Daraz_V_Convert.DL.SellerDL.get_seller()[i]= nw
    #         i += 1
    # @staticmethod
    # def delete(index):
    #     Daraz_V_Convert.DL.SellerDL._seller.pop(index)
    # @staticmethod
    # def get_products(name):
    #     i = 0
    #     while i < len(Daraz_V_Convert.DL.SellerDL._seller):
    #         if name == Daraz_V_Convert.DL.SellerDL._seller[i].get_name():
    #             return Daraz_V_Convert.DL.SellerDL._seller[i].get_products()
    #         i += 1
    #     return None

    # @staticmethod
    # def store_data():
        # var = StreamWriter(Daraz_V_Convert.DL.SellerDL._path, False)
        # i = 0
        # while i < len(Daraz_V_Convert.DL.SellerDL._seller):
        #     var.Write(Daraz_V_Convert.DL.SellerDL._seller[i].get_name() + "," + Daraz_V_Convert.DL.SellerDL._seller[i].get_phone_num() + "," + Daraz_V_Convert.DL.SellerDL._seller[i].get_buisness() + "," + Daraz_V_Convert.DL.SellerDL._seller[i].get_password() + "," + str(len(Daraz_V_Convert.DL.SellerDL._seller[i].get_products()))+",")

        #     m = 0
        #     while m < len(Daraz_V_Convert.DL.SellerDL._seller[i].get_products()):
        #         var.Write(Daraz_V_Convert.DL.SellerDL._seller[i].get_products()[m].get_name() + ";" + str(Daraz_V_Convert.DL.SellerDL._seller[i].get_products()[m].get_prices()) + ";" + str(Daraz_V_Convert.DL.SellerDL._seller[i].get_products()[m].get_quantity()))
        #         if m!= len(Daraz_V_Convert.DL.SellerDL._seller[i].get_products())-1:
        #             var.Write("$")
        #         m += 1
        #     var.WriteLine("")
        #     i += 1
        # var.Close()
    # @staticmethod
    # def loadData():
    #     path = "seller.txt"
    #     if File.Exists(path):
    #         var = StreamReader(path)
    #         record = None
    #         while (record = var.ReadLine()) is not None:
    #             splitData = record.split(',')
    #             s = Seller()
    #             s.set_name(splitData[0])
    #             s.set_phone_num(splitData[1])
    #             s.set_buisness(splitData[2])
    #             s.set_password(splitData[3])
    #             count = int.Parse(splitData[4])
    #             list = splitData[5]
    #             splitList = list.split('$')
    #             for i in range(0, count):
    #                 pline = splitList[i]
    #                 po = pline.split(';')
    #                 p = Product()
    #                 p.set_name(po[0])
    #                 p.set_prices(int.Parse(po[1]))
    #                 p.set_quantity(int.Parse(po[2]))
    #                 s.add_product(p)
    #             Daraz_V_Convert.DL.SellerDL._seller.append(s)
    #         var.Close()





