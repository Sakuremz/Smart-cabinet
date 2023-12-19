# SmartBox
# +---------->所有默认的参数<----------+
# |                                  |
# |    登录账号>>>sakura              |
# |    登录密码>>>qwqw1378            |
# |	 Mysql账号>>>root                |
# |	 Mysql密码>>>qwqw1378            |
# |	 Mysql数据库名>>>sakura           |
# |	 Mysql数据库表1>>>item_group      |
# |  Mysql数据库表2>>>userinfo        |
# |	 Mysql_IP地址>>>localhost        |
# |	 Mysql端口>>>3306                |
# |                                 |
# +---------------------------------+

# 数据表1 item_group 存储各个柜子的信息
# 数据包2 user_info  存储用户信息

# 数据库可以自定义修改,默认为sakura
# Form4.cs文件的Login_Load进行修改
# 不想动的话可以直接修改DataBaseinfo.ini里面的参数

# 登录等功能都靠Mysql实现，无Mysql软件就寄了

# packages包
# MySql.Data.8.0.11
# Newtonsoft.Json.13.0.3