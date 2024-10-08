using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 新手指导信息 message
 */
public class ResFreshGuideInfoMessage : Message 
{
	//新手指导信息
	List<int> _completedIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//新手指导信息
		SerializeUtils.WriteShort(stream, (short)_completedIds.Count);

		foreach (var element in _completedIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//新手指导信息
		int _completedIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _completedIds_length; ++i) 
		{
			_completedIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 新手指导信息
	 * @return 
	 */
	public List<int> GetCompletedIds()
	{
		return _completedIds;
	}
	
	/**
	 * set 新手指导信息
	 */
	public void SetCompletedIds(List<int> completedIds)
	{
		_completedIds = completedIds;
	}
	
	
	public override int GetId() 
	{
		return 213101;
	}
}