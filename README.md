EFSQLite
========

asp.net using sqlite with entity framework 6

*使用nuget安装system.data.sqlite后，修改配置文件：entityframework -> providers，新增节点*

`
<provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
`
