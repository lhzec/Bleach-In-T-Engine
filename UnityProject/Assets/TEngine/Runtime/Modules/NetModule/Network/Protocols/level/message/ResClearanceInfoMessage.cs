using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回通关结果信息 message
 */
public class ResClearanceInfoMessage : Message 
{
	//通关信息
	ClearanceInfo _clearanceInfo;	
	//通关奖励
	LevelRewardInfo _levelRewardInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//通关信息
		SerializeUtils.WriteBean(stream, _clearanceInfo);
		//通关奖励
		SerializeUtils.WriteBean(stream, _levelRewardInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//通关信息
		_clearanceInfo = SerializeUtils.ReadBean<ClearanceInfo>(stream);
		//通关奖励
		_levelRewardInfo = SerializeUtils.ReadBean<LevelRewardInfo>(stream);
	}
	
	/**
	 * 通关信息
	 */
	public ClearanceInfo ClearanceInfo
	{
		set { _clearanceInfo = value; }
	    get { return _clearanceInfo; }
	}
	
	/**
	 * 通关奖励
	 */
	public LevelRewardInfo LevelRewardInfo
	{
		set { _levelRewardInfo = value; }
	    get { return _levelRewardInfo; }
	}
	
	
	public override int GetId() 
	{
		return 102101;
	}
}