# 1. 建立新的微服务
我司的微服务是基于一套基础类库构建而来，新建里一个微服务，需要引用框架解决方案以及构造自己的automapper类，以及初始化类，错误代码类等，微服务解决方案按照既定约定进行命名，构造整体过程并不繁琐，所以一直没有生成响应的模板。
最近有时间研究下dotnet new模板的构成，发现极其简单，因此，按照教程构建一个包，记录如下。
# 2.准备环境
 *  .NET Core 2.0 SDK 或更高版本。
 * 现有的微服务项目解决方案
 * nuget.exe 
# 3.以现有的微服务项目为模板
 * step1: 使用已确认可以编译和运行的现有项目，把该项目放在Content文件夹下，并在Content文件夹下建立文件夹目录 .template.config。
* step 2：在 .template.config 文件夹中，创建 template.json 文件来配置模板。 
```json
{
  "$schema": "http://json.schemastore.org/template",
  "author": "webmote",
  "classifications": [ "microService", "Console","quantum","webmote" ],
  "identity": "Quantum.MicroService",
  "name": "微服务Application",
  "shortName": "qms",
  "tags": {
    "language": "C#"                       // Specify that this template is in C#.
	},
	"sourceName": "Appointment",  //需要替换的文件夹名称
	"preferNameDirectory":"true"
}
```
# 4.分发模板
Content文件夹同目录下增加 nuspec 文件，并配置如下：
```xml
<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2012/06/nuspec.xsd">
  <metadata>
    <id>Qms.MicroService</id>
    <version>1.0.0</version>
    <description>
      微服务模板
    </description>
    <authors>webmote</authors>
    <packageTypes>
      <packageType name="Template" />
    </packageTypes>
  </metadata>
</package>
```
# 5.nuget pack打包
```shell
nuget pack ***\***.nuspec
```
# 6.本地安装
```shell
dotnet new -i ***\***1.0.0.nupkg
```
# 7.使用新模板
```shell
dotnet new qms -n Test  
```
a、安装 ：dotnet new -i E:\oms_source\SCM.Template\Quantum.MicroService.1.0.0.nupkg
b、应该在框架git同目录，否则引用框架会报错
c、运行 : dotnet new qms -n Test   会建立一个新的Test目录，并包含解决方案，以及三个项目：SCM.Test.Service 等
# 8.完整代码参看github
****
在此我向大家推荐一个微服务架构学习交流群。交流学习群号：864759589  里面会分享一些资深架构师录制的视频录像：高并发、高性能、分布式、微服务架构的原理，分布式架构等这些成为架构师必备的知识体系。
![在这里插入图片描述](https://img-blog.csdnimg.cn/20181128131828836.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlYm1vdGU=,size_16,color_FFFFFF,t_70)
**** 

# 引用链接
1. [口袋代码仓库](http://codeex.cn)
2. [在线计算器](http://jisuanqi.codeex.cn)
3. 本节源码：[github](https://github.com/webmote-org/)

  
