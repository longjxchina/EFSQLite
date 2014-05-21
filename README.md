EFSQLite
========

运行环境
----------------
.net framework 4.5 + entity framework 6

配置（本程序已经修改过了）
--------------------------

*使用nuget安装system.data.sqlite后，修改配置文件：entityframework -> providers，新增节点*

```bash
<provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
```
