# EventAndDelegate

2018-7-18
MediatR��netcore ���ڴ���ʽ�������ĵ�ʵ������� �� Heater(����Ŀ�м����������ӣ� �� �������ĵ�����
	MediatR
		�¼� ProjectCreateCommand:IRequest<string>
		�¼������ࣺProjectCreateeCommandHandler:IRequestHandler< ProjectCreateCommand,string> 
		�������� ProjectCreateeCommandHandler.Handler
	Heater
		�¼���BoilEvent
		�¼������ࣺ���������ߵĴ����� 
			Alarm
			Display
		�¼�������
			Alarm.MakeAlert(object sender, BoiledEventArgs boiledEventArgs)
			Display.ShowMsg(object sender, BoiledEventArgs boiledEventArgs)

	�¼����¼������� ע��Ͷ��ķ�ʽ�Ĳ�ͬ
		Heater �е� BoilEvent ����뷽ʽ�ֶ�ע�� Alarm.MakeAlert   Display.ShowMsg
		MediatR �� ����� 
			ProjectCreateeCommandHandler: IRequestHandler<T1,T2> �� T1:IRequest<string>�� T1 �Ĺ���
			--ProjectCreateeCommandHandler: IRequestHandler<ProjectCreateCommand,string> �� ProjectCreateCommand:IRequest<string>�� T1 
		�Զ�scan �ҵ����Ӷ����ע�ᴦ����Ĵ�����			


2018-7-15
1   
delegate void GreetingDelegate(string name)
event  GreetingDelegate  MakeGreet
��ͬ�㣺
	GreetingDelegate ��һ��ί������
	MakeGreet event Ҳ��һ��GreetingDelegate���͵�ί��
��ͬ��
	�������ϲ�ͬ
		public event  GreetingDelegate  MakeGreet;
		���ڲ� ����ֱ�ӷ���
		�ⲿ�� ��һ��˽�з���private 
			��Ҫͨ�� -=,+=��ʹ��