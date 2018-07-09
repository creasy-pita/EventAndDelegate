# EventAndDelegate

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