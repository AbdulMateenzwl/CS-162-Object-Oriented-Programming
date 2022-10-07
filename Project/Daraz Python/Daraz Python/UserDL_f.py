from UserBL_f import UserBL

class UserDL:
    users=[]
    
    def add_list(user):
        UserDL.users.append(user)
    def check_user(user):
        for i in range(len(UserDL.users)):
            if user.name == UserDL.users[i].name and user.password ==  UserDL.users[i].password :
                return UserDL.users[i]
        return None