using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动开启 message
 */
public class ResActivityOpenMessage : Message 
{
	//开启的活动信息
	List<ActivityData> _activityData = new List<ActivityData>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开启的活动信息
		SerializeUtils.WriteShort(stream, (short)_activityData.Count);

		foreach (var element in _activityData)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开启的活动信息
		int _activityData_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _activityData_length; ++i) 
		{
			_activityData.Add(SerializeUtils.ReadBean<ActivityData>(stream));
		}
	}
	
	/**
	 * get 开启的活动信息
	 * @return 
	 */
	public List<ActivityData> GetActivityData()
	{
		return _activityData;
	}
	
	/**
	 * set 开启的活动信息
	 */
	public void SetActivityData(List<ActivityData> activityData)
	{
		_activityData = activityData;
	}
	
	
	public override int GetId() 
	{
		return 311108;
	}
}