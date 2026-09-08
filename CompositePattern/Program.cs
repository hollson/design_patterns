// 组合模式（Composite Pattern）：将对象组合成树形结构以表示"部分-整体"层次，
// 使客户端对单个对象（叶子）和组合对象（容器）的使用具有一致性。
// 本示例演示两种风格：透明式（文件系统）、安全式（组织架构）。

using CompositePattern;

Console.WriteLine("\n========== 组合模式 (Composite Pattern) ==========");
Console.WriteLine("将对象组合成树形结构，使叶子与容器的使用具有一致性\n");

// ① 透明式：文件系统，树形展示 + 大小聚合
Console.WriteLine("--- 透明式: 文件系统 ---");

var src = new FolderNode("src");
src.Add(new FileNode("Program.cs", 1200));
src.Add(new FileNode("Utils.cs", 800));

var docs = new FolderNode("docs");
docs.Add(new FileNode("README.md", 600));

var project = new FolderNode("project");
project.Add(src);
project.Add(docs);
project.Add(new FileNode("global.json", 100));

project.Display();   // 一次调用，递归输出整棵树
Console.WriteLine($">> du: project 总大小 {project.Size()} B");

// 透明式的代价：叶子调用容器方法，运行期才报错
var file = new FileNode("temp.txt", 10);
try { file.Add(new FileNode("inner.txt", 5)); }
catch (NotSupportedException) { Console.WriteLine(">> 文件调用 Add: NotSupportedException（透明式运行期才暴露误用）"); }
Console.WriteLine("\n");

// ② 安全式：组织架构，人数与薪资聚合
Console.WriteLine("--- 安全式: 组织架构 ---");

var backend = new Department("后端组");
backend.Add(new Employee("张三", 25000));
backend.Add(new Employee("李四", 22000));

var frontend = new Department("前端组");
frontend.Add(new Employee("王五", 20000));

var tech = new Department("技术部");
tech.Add(backend);
tech.Add(frontend);
tech.Add(new Employee("赵六", 30000));   // 部门直属员工与子部门同级共存

var hr = new Department("人事部");
hr.Add(new Employee("钱七", 15000));

var company = new Department("总公司");
company.Add(tech);
company.Add(hr);

company.Print();     // 一次调用，递归输出组织树
Console.WriteLine($">> HeadCount: 总人数 {company.HeadCount()}");
Console.WriteLine($">> TotalSalary: 月薪总额 {company.TotalSalary()}");
