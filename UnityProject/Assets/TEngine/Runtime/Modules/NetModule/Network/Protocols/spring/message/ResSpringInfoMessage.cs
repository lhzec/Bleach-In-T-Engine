using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 温泉信息 message
 */
public class ResSpringInfoMessage : Message 
{
	//进入温泉次数
	int _springTimes;	
	//温泉幸运组合
	List<SpringCombination> _springCombinations = new List<SpringCombination>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//进入温泉次数
		SerializeUtils.WriteInt(stream, _springTimes);
		//温泉幸运组合
		SerializeUtils.WriteShort(stream, (short)_springCombinations.Count);

		foreach (var element in _springCombinations)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//进入温泉次数
		_springTimes = SerializeUtils.ReadInt(stream);
		//温泉幸运组合
		int _springCombinations_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _springCombinations_length; ++i) 
		{
			_springCombinations.Add(SerializeUtils.ReadBean<SpringCombination>(stream));
		}
	}
	
	/**
	 * 进入温泉次数
	 */
	public int SpringTimes
	{
		set { _springTimes = value; }
	    get { return _springTimes; }
	}
	
	/**
	 * get 温泉幸运组合
	 * @return 
	 */
	public List<SpringCombination> GetSpringCombinations()
	{
		return _springCombinations;
	}
	
	/**
	 * set 温泉幸运组合
	 */
	public void SetSpringCombinations(List<SpringCombination> springCombinations)
	{
		_springCombinations = springCombinations;
	}
	
	
	public override int GetId() 
	{
		return 306104;
	}
}