using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 根据配置的时间刷新温泉幸运组合 message
 */
public class ResRefreshLuckyCombinationsMessage : Message 
{
	//温泉幸运组合角色
	List<SpringCombination> _springCombinations = new List<SpringCombination>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//温泉幸运组合角色
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
		//温泉幸运组合角色
		int _springCombinations_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _springCombinations_length; ++i) 
		{
			_springCombinations.Add(SerializeUtils.ReadBean<SpringCombination>(stream));
		}
	}
	
	/**
	 * get 温泉幸运组合角色
	 * @return 
	 */
	public List<SpringCombination> GetSpringCombinations()
	{
		return _springCombinations;
	}
	
	/**
	 * set 温泉幸运组合角色
	 */
	public void SetSpringCombinations(List<SpringCombination> springCombinations)
	{
		_springCombinations = springCombinations;
	}
	
	
	public override int GetId() 
	{
		return 306103;
	}
}