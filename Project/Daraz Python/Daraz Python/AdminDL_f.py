from asyncio.windows_events import NULL
from Admin_f import Admin

class AdminDL :
    path = "Admin.txt"
    admin = Admin("0","0")

    @staticmethod
    def get_admin():
        return AdminDL.admin

    @staticmethod
    def set_admin(value):
        AdminDL.admin = value

    @staticmethod
    def chk_admin(admin):
        if admin.get_username() == AdminDL.admin.get_username() and AdminDL.admin.get_password() == admin.get_password():
            return AdminDL.admin
        else:
            return NULL

    @staticmethod
    def change_password(pass_, pass1, pass2):
        if pass_ == Admin.admin.get_password():
            if pass1 == pass_:
                return 2
            else:
                if pass1 == pass2:
                    Admin.admin.set_password(pass1)
                    return 3
                else:
                    return 4
        else:
            return 1

    #@staticmethod
    #    def load_data():
    #    a = StreamReader(Admin.path)
    #    Admin.admin.set_username(a.ReadLine())
    #    Admin.admin.set_password(a.ReadLine())
    #    a.Close()
    #@staticmethod
    #def store_data():
    #    a = StreamWriter(Admin.path, False)
    #    a.WriteLine(Daraz_V_Convert.DL.AdminDL.get_admin().get_username())
    #    a.WriteLine(Daraz_V_Convert.DL.AdminDL.get_admin().get_password())
    #    a.Flush()
