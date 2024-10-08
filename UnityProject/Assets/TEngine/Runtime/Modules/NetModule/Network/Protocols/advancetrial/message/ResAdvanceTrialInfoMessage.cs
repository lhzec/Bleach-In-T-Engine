using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回灵力修炼信息[初始化] message
 */
public class ResAdvanceTrialInfoMessage : Message 
{
	//已通过的灵力试炼列表
	List<int> _passedAdvanceTrialIdList = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//已通过的灵力试炼列表
		SerializeUtils.WriteShort(stream, (short)_passedAdvanceTrialIdList.Count);

		foreach (var element in _passedAdvanceTrialIdList)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//已通过的灵力试炼列表
		int _passedAdvanceTrialIdList_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _passedAdvanceTrialIdList_length; ++i) 
		{
			_passedAdvanceTrialIdList.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 已通过的灵力试炼列表
	 * @return 
	 */
	public List<int> GetPassedAdvanceTrialIdList()
	{
		return _passedAdvanceTrialIdList;
	}
	
	/**
	 * set 已通过的灵力试炼列表
	 */
	public void SetPassedAdvanceTrialIdList(List<int> passedAdvanceTrialIdList)
	{
		_passedAdvanceTrialIdList = passedAdvanceTrialIdList;
	}
	
	
	public override int GetId() 
	{
		return 224103;
	}
}