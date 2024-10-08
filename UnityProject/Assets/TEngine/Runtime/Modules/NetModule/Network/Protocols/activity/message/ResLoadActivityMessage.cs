using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 普通活动 message
 */
public class ResLoadActivityMessage : Message 
{
	//活动数据集合
	List<ActivityData> _activityList = new List<ActivityData>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//活动数据集合
		SerializeUtils.WriteShort(stream, (short)_activityList.Count);

		foreach (var element in _activityList)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//活动数据集合
		int _activityList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _activityList_length; ++i) 
		{
			_activityList.Add(SerializeUtils.ReadBean<ActivityData>(stream));
		}
	}
	
	/**
	 * get 活动数据集合
	 * @return 
	 */
	public List<ActivityData> GetActivityList()
	{
		return _activityList;
	}
	
	/**
	 * set 活动数据集合
	 */
	public void SetActivityList(List<ActivityData> activityList)
	{
		_activityList = activityList;
	}
	
	
	public override int GetId() 
	{
		return 311103;
	}
}