using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动开启关闭 message
 */
public class ResNotificationActivityMessage : Message 
{
	//0是通知活动开始,1 关闭 
	int _type;	
	//id活动
	List<int> _idList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0是通知活动开始,1 关闭 
		SerializeUtils.WriteInt(stream, _type);
		//id活动
		SerializeUtils.WriteShort(stream, (short)_idList.Count);

		foreach (var element in _idList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0是通知活动开始,1 关闭 
		_type = SerializeUtils.ReadInt(stream);
		//id活动
		int _idList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _idList_length; ++i) 
		{
			_idList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 0是通知活动开始,1 关闭 
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * get id活动
	 * @return 
	 */
	public List<int> GetIdList()
	{
		return _idList;
	}
	
	/**
	 * set id活动
	 */
	public void SetIdList(List<int> idList)
	{
		_idList = idList;
	}
	
	
	public override int GetId() 
	{
		return 311104;
	}
}