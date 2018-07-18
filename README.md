# EventAndDelegate

2018-7-18
MediatR（netcore 中内存形式发布订阅的实现组件） 和 Heater(本项目中加热器的例子） 中 发布订阅的区别
	MediatR
		事件 ProjectCreateCommand:IRequest<string>
		事件处理类：ProjectCreateeCommandHandler:IRequestHandler< ProjectCreateCommand,string> 
		处理方法： ProjectCreateeCommandHandler.Handler
	Heater
		事件：BoilEvent
		事件处理类：各个订阅者的处理类 
			Alarm
			Display
		事件处理方法
			Alarm.MakeAlert(object sender, BoiledEventArgs boiledEventArgs)
			Display.ShowMsg(object sender, BoiledEventArgs boiledEventArgs)

	事件和事件处理类 注册和订阅方式的不同
		Heater 中的 BoilEvent 会代码方式手动注册 Alarm.MakeAlert   Display.ShowMsg
		MediatR 中 会根据 
			ProjectCreateeCommandHandler: IRequestHandler<T1,T2> 与 T1:IRequest<string>中 T1 的关联
			--ProjectCreateeCommandHandler: IRequestHandler<ProjectCreateCommand,string> 与 ProjectCreateCommand:IRequest<string>中 T1 
		自动scan 找到监视对象和注册处理类的处理方法			


2018-7-15
1   
delegate void GreetingDelegate(string name)
event  GreetingDelegate  MakeGreet
相同点：
	GreetingDelegate 是一个委托类型
	MakeGreet event 也是一个GreetingDelegate类型的委托
不同点
	访问性上不同
		public event  GreetingDelegate  MakeGreet;
		类内部 可以直接访问
		外部类 是一个私有方法private 
			需要通过 -=,+=来使用